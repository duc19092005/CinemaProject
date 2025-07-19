﻿using backend.Data;
using backend.Enum;
using backend.Interface.Schedule;
using backend.Model.Movie;
using backend.ModelDTO.GenericRespond;
using backend.ModelDTO.ScheduleDTO.Request;
using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Concurrent;
using System.Linq;

namespace backend.Services.Schedule
{
    public class ScheduleServices : IScheduleServices
    {
        public readonly DataContext _dataContext;

        public ScheduleServices(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<GenericRespondDTOs> add(ScheduleRequestDTO scheduleRequestDTO)
        {
            var findMovieVisualFormat =
                _dataContext.movieVisualFormatDetails
                .Where(x => x.movieId.Equals(scheduleRequestDTO.movieID))
                .Include(x => x.movieInformation)
                .Include(x => x.movieVisualFormat);

            var selectedMovieVisualFormat =
                findMovieVisualFormat.Select
                (x => x.movieVisualFormatId);

            var checkIsMovieSupported = false;

            foreach (var scheduleDate in scheduleRequestDTO.scheduleDateDTOs)
            {
                foreach (var visualFormat in scheduleDate.ScheduleVisualFormatDTOs)
                {
                    if (selectedMovieVisualFormat.Contains(visualFormat.visualFormatID))
                    {
                        checkIsMovieSupported = true;
                    }
                }
            }

            if (checkIsMovieSupported)
            {
                try
                {
                    List<movieSchedule> movieSchedules = new List<movieSchedule>();
                    foreach (var scheduleDate in scheduleRequestDTO.scheduleDateDTOs)
                    {
                        // Tạo ID mới
                        // Duyệt phòng 
                        foreach (var visualFormat in scheduleDate.ScheduleVisualFormatDTOs)
                        {
                            foreach (var showTime in visualFormat.scheduleShowTimeDTOs)
                            {
                                foreach (var rooms in showTime.scheduleRoomDTOs)
                                {
                                    var scheduleID = Guid.NewGuid().ToString();
                                    var newSchedule = new movieSchedule()
                                    {
                                        movieScheduleId = scheduleID,
                                        movieId = scheduleRequestDTO.movieID,
                                        cinemaRoomId = rooms.roomID,
                                        DayInWeekendSchedule = "Null",
                                        HourScheduleID = showTime.showTimeID,
                                        ScheduleDate = scheduleDate.startDate,
                                        movieVisualFormatID = visualFormat.visualFormatID,
                                        IsDelete = false

                                    };
                                    movieSchedules.Add(newSchedule);
                                }
                            }
                        }
                    }
                    await _dataContext.movieSchedule.AddRangeAsync(movieSchedules);
                    await _dataContext.SaveChangesAsync();
                    return new GenericRespondDTOs()
                    {
                        message = "Thành công rồi , chúc mừng bạn đã vượt qua được nhiều vòng lặp for mới thêm được Data",
                        Status = GenericStatusEnum.Success.ToString(),
                    };
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return new GenericRespondDTOs()
                    {
                        message = "Lỗi liên quan tới Database vui lòng liên hệ dev để fix",
                        Status = GenericStatusEnum.Failure.ToString()
                    };
                }
            }
            return new GenericRespondDTOs()
            {
                message = "Lỗi Phim không hỗ trợ định dạng này !" ,
                Status = GenericStatusEnum.Failure.ToString()
            };
        }
         
        public async Task<bool> edit(string Movieid, ScheduleRequestDTO scheduleRequestDTO)
        {
            var findMovieVisualFormat =
               _dataContext.movieVisualFormatDetails
               .Where(x => x.movieId.Equals(scheduleRequestDTO.movieID))
               .Include(x => x.movieInformation)
               .Include(x => x.movieVisualFormat);

            var selectedMovieVisualFormat =
                findMovieVisualFormat.Select
                (x => x.movieVisualFormatId);

            var checkIsMovieSupported = false;

            foreach (var scheduleDate in scheduleRequestDTO.scheduleDateDTOs)
            {
                foreach (var visualFormat in scheduleDate.ScheduleVisualFormatDTOs)
                {
                    if (selectedMovieVisualFormat.Contains(visualFormat.visualFormatID))
                    {
                        checkIsMovieSupported = true;
                    }
                }
            }

            if (checkIsMovieSupported)
            {
                var usingTransition = _dataContext.Database.BeginTransaction();
                try
                {
                    var findMovieSchedule = _dataContext.movieSchedule.Where(x => x.movieId.Equals(Movieid));
                    // Xóa List
                    _dataContext.movieSchedule.RemoveRange(findMovieSchedule);

                    List<movieSchedule> movieSchedules = new List<movieSchedule>();
                    foreach (var scheduleDate in scheduleRequestDTO.scheduleDateDTOs)
                    {
                        // Tạo ID mới
                        // Duyệt phòng trong mảng ngày
                        foreach (var visualFormat in scheduleDate.ScheduleVisualFormatDTOs)
                        {
                            foreach (var showTime in visualFormat.scheduleShowTimeDTOs)
                            {
                                foreach (var rooms in showTime.scheduleRoomDTOs)
                                {
                                    var scheduleID = Guid.NewGuid().ToString();
                                    var newSchedule = new movieSchedule()
                                    {
                                        movieScheduleId = scheduleID,
                                        movieId = scheduleRequestDTO.movieID,
                                        cinemaRoomId = rooms.roomID,
                                        DayInWeekendSchedule = "Null",
                                        HourScheduleID = showTime.showTimeID,
                                        ScheduleDate = scheduleDate.startDate,
                                        movieVisualFormatID = visualFormat.visualFormatID,
                                        IsDelete = false

                                    };
                                    movieSchedules.Add(newSchedule);
                                }
                            }
                        }
                    }
                    await _dataContext.movieSchedule.AddRangeAsync(movieSchedules);
                    await _dataContext.SaveChangesAsync();
                    await usingTransition.CommitAsync();

                    return true;
                }
                catch (Exception e)
                {
                    await usingTransition.RollbackAsync();
                    return false;
                }

            }
            return false;
        }

        public async Task<bool> delete(string id, string options)
        {
          
            // Options xóa lịch chiếu theo MovieID đồng nghĩa việc xóa hết lịch chiếu
            if (options.ToLower().Equals("movie"))
            {
                // Tìm kiếm lịch chiếu bởi phim
                var findMovieSchedule = _dataContext.movieSchedule.Where(x => x.movieId.Equals(id));

                var SelectedAllMovieScheduleID = findMovieSchedule.Select(x => x.movieScheduleId).ToList();

                bool findOrder = false;
                // Tìm kiếm Order

                foreach(var items in findMovieSchedule.Select(x => x.orderDetailTicket.Select(x => x.movieScheduleID)))
                {
                    foreach (var findMovieScheduleID in items)
                    {
                        findOrder = await 
                            findMovieSchedule
                            .AnyAsync(x => SelectedAllMovieScheduleID
                            .Contains(findMovieScheduleID));
                    }
                }

                if (findOrder)
                {
                    return false;
                }

                // Tiến hành câp nhật Data

                // Set trạng thái == đã xóa

                var setDeleteStatusList = findMovieSchedule.ToList();
                foreach (var items in setDeleteStatusList)
                {
                    items.IsDelete = true;
                }

                _dataContext.movieSchedule.UpdateRange(setDeleteStatusList);
                await _dataContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}

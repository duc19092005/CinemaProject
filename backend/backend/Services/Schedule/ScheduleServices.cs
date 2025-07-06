using backend.Data;
using backend.Interface.Schedule;
using backend.Model.Movie;
using backend.ModelDTO.ScheduleDTO.Request;
using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> add(ScheduleRequestDTO scheduleRequestDTO)
        {
            bool result = false;
            foreach (var scheduleDate in scheduleRequestDTO.scheduleDateDTOs)
            {
                // Tạo ID mới
                // Duyệt phòng trong mảng ngày
                foreach (var cinema in scheduleDate.scheduleCinemaDTOs)
                {
                    // Duyệt phòng 
                    foreach (var visualFormat in cinema.ScheduleVisualFormat)
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
                                await _dataContext.movieSchedule.AddAsync(newSchedule);
                                result = true;
                            }
                        }
                    }
                }
            }
            if (result)
            {
                await _dataContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> edit(string Movieid, ScheduleRequestDTO scheduleRequestDTO)
        {
            // Xóa hết các movieID để tạo lại từ đầu Edit 

            var findMovieSchedule = _dataContext.movieSchedule.Where(x => x.movieId.Equals(Movieid));
            // Xóa List
            _dataContext.movieSchedule.RemoveRange(findMovieSchedule);

            bool result = false;
            foreach (var scheduleDate in scheduleRequestDTO.scheduleDateDTOs)
            {
                // Tạo ID mới
                // Duyệt phòng trong mảng ngày
                foreach (var cinema in scheduleDate.scheduleCinemaDTOs)
                {
                    // Duyệt phòng 
                    foreach (var visualFormat in cinema.ScheduleVisualFormat)
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
                                await _dataContext.movieSchedule.AddAsync(newSchedule);
                                result = true;
                            }
                        }
                    }
                }
            }
            if (result)
            {
                await _dataContext.SaveChangesAsync();
                return true;
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
                        findOrder = await findMovieSchedule.AnyAsync(x => SelectedAllMovieScheduleID.Contains(findMovieScheduleID));
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

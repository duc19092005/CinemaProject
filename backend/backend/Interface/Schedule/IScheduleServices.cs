using backend.ModelDTO.ScheduleDTO.Request;

namespace backend.Interface.Schedule
{
    public interface IScheduleServices
    {
        Task<bool> add(ScheduleRequestDTO scheduleRequestDTO);

        Task<bool> edit(string id ,ScheduleRequestDTO scheduleRequestDTO);

        Task<bool> delete(string id , string options);
    }
}

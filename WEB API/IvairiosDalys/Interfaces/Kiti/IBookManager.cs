using L05_Tasks_MSSQL.Models.DTO;

namespace ApiMokymai.Services
{
    public interface IBookManager
    {
        int Add(CreateBookDto book);
        void Delete(int id);
        bool Exists(int id);
        List<GetBookDto> Filter(Dictionary<string, string> filter);
        List<GetBookDto> Get();
        GetBookDto Get(int id);
        void Update(UpdateBookDto book);
    }
}

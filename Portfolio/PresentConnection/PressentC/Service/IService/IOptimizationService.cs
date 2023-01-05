using PressentConnection;
using static PressentConnection.Program;

namespace PressentC.Service.IService
{
    public interface IOptimizationService
    {
       // List<Project> GenerateProjects(int count);
        Task<List<Project>> GenerateProjectsAsync(int count);
      //  List<PressentConnection.Program.Root> GenerateRoots(int count);
        Task<List<Root>> GenerateRootsAsync(int count);
        Task Start();
        void UpdateRoot(List<Project> projects, List<PressentConnection.Program.Root> roots);
    }
}
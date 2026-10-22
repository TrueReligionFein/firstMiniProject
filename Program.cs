using miniProject.ciewModel;
using miniProject.viewModel.view;

class Program
{
    static async Task Main(string[] args)
    {
        await using AppDbContext appContext = new AppDbContext();
        Teacher teacherNumberOne = new Teacher("Мария Петровна", 76);
        appContext.teachers.Add(teacherNumberOne);
        await appContext.SaveChangesAsync();
        var teacher = await appContext.teachers.FindAsync(1);

        if(teacher == null)
        {
            return;
        }

        teacher.showStats();
    }
}
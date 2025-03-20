namespace Assignments;

public enum EmployeeState
{
    PartTime,
    FullTime,
}

public class Employee(
    int id = 0,
    string name = "Undefined",
    double salary = 0,
    EmployeeState state = EmployeeState.FullTime,
    int time = 0
)
{
    //time is monthly based
    public void Info()
    {
        Console.WriteLine(
            $"name: {name}, salary: {salary}, state: {state}, time: {time}, id: {id}"
        );
    }

    public double GetBonus()
    {
        var workHours = state == EmployeeState.PartTime ? 80 : 160;
        float bonusPercentage = state == EmployeeState.PartTime ? 5 : 10;
        var hoursBalance = time - workHours;
        var salaryForHours = salary / workHours;

        return (salaryForHours * hoursBalance) * (100 + bonusPercentage) / 100;
        ;
    }
}

public class EmployeeTasks()
{
    public static void RunTasks()
    {
        var employee = new Employee(1, "Suren", 20000, EmployeeState.FullTime);

        employee.Info();
        Console.WriteLine(employee.GetBonus());
    }
}

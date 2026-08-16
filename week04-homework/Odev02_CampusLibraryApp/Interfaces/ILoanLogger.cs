namespace CampusLibraryApp.Interfaces;

public interface ILoanLogger
{
    void Log(
        string memberId,
        string bookId,
        string operation,
        string details);

    List<string> GetHistory(string memberId);
}
using LINQTut06.Pagination;
using LINQTut06.Shared;

int page = 1;
int size = 10;

Console.Write("result per page: ");

if (int.TryParse(Console.ReadLine(), out int resultPerPage))
    size = resultPerPage;

Console.Write("Page No.: ");
if (int.TryParse(Console.ReadLine(), out int pageNo))
    page = pageNo;

var emps = Repository.LoadEmployees();

var result = emps.Paginate(page, size);

var resultCount = result.Count();

var startRecord = ((page - 1) * size) + 1;

var  endRecord = 
    resultCount < size 
    ? startRecord + resultCount -1 
    : size * (page - 1) + size;

result.Print($"showing employees #{startRecord} — {endRecord}");



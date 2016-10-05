#include "Lab8Helper.h"
using namespace std;

void main()
{
	Lab8Helper obj("data.txt", "res.txt");
	obj.InitData();
	obj.PrintData();
	obj.AnalyzeData();
	obj.PrintResults();
}
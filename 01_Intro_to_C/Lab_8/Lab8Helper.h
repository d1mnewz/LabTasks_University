#pragma once
#include <iostream>
#include <vector>
#include <fstream>
#include <string>
using namespace std;
class Lab8Helper
{
private:
	vector<int> data;
	char * inFile;
	char * outFile;
	int lines;
	int max;
	int count;
public:
	void InitData();
	void AnalyzeData();
	void PrintResults();
	Lab8Helper();
	Lab8Helper(char * iFile, char * oFile);
	void PrintData();
	~Lab8Helper();
};

#pragma once


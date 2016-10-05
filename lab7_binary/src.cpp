#include <iostream>
#include <vector>
#include <fstream>
#include <string>
#include <time.h>
using namespace std;
void writeToBinData(const char * filename)
{
	int lines = rand() % 10;
	int tmp = 0;
	ofstream iFile(filename, ios::binary);
	iFile.write((char*)&lines, sizeof(lines));
	for (int i = 1; i <= lines; i++)
	{
		tmp = rand() % 100;
		iFile.write((char*)&tmp, sizeof(tmp));
	}
	iFile.close();


}
void readFromBinResults(const char * filename)
{
	int tmp1 = 0;
	int tmp2 = 0;
	ifstream i(filename, ios::binary);
	i.read((char*)&tmp1, sizeof(tmp1));
	i.read((char*)&tmp2, sizeof(tmp2));
	cout << tmp1 << " " << tmp2 << endl;
}
void main()
{ 
	// made without forming input data binary file !!!!!
	// just cant get it
	srand(time(NULL));
	vector<int> data;
	const char * iFile = "data.txt";
	const char * oFile = "res.bin";
	int tmp = 0;
	int max = 0;
	int count = 0;
	ifstream read(iFile);
	ofstream result(oFile, ios::binary);
	int lines = 0;
	read >> lines; //number of lines
	for (int i = 1; i <= lines; i++)
	{
		read >> tmp;
		data.push_back(tmp);
	}
	read.close();
	cout << "File input:" << endl;
	for (int i = 0; i < lines; i++)
	{
		cout << data[i] << endl;
	}

	for (int i = 0; i < lines; i++)
	{
		if (data[i] > max)
		{
			max = data[i];
			count = 1;
		}
		else if (data[i] == max)
		{
			count++;
		}
	}
	result.write((char*)&max, sizeof(max));
	result.write((char*)&count, sizeof(count));
	result.close();
	readFromBinResults(oFile);
	//result << "max value = " << max << " count = " << count << endl;
	//result.close();
	//ifstream read("data.txt");
	
}
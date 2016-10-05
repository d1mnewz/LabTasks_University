#include <iostream>
#include <vector>
#include <fstream>
#include <string>
using namespace std;

void main()
{
	vector<int> data;
	int tmp = 0;
	int max = 0;
	int count = 0;
	ifstream read("data.txt");
	ofstream result("res.txt");
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
	result << "max value = " << max << " count = " << count << endl;
	result.close();
}
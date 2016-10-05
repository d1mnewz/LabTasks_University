#include "Lab8Helper.h"


void Lab8Helper::InitData()
{
	ifstream in(inFile);
	
	int tmp = 0;
	in >> this->lines; //number of lines
	for (int i = 1; i <= this->lines; i++)
	{
		in >> tmp;
		data.push_back(tmp);
	}
	in.close();
}

void Lab8Helper::AnalyzeData()
{
	for (int i = 0; i < this->lines; i++)
	{
		if (data[i] > this->max)
		{
			this->max = this->data[i];
			this->count = 1;
		}
		else if (this->data[i] == this->max)
		{
			this->count++;
		}
	}
}

void Lab8Helper::PrintResults()
{
	cout << "Max value = " << this->max << "; Count = " << this->count << endl;
}

Lab8Helper::Lab8Helper()
{

}
Lab8Helper::Lab8Helper(char * iFile, char * oFile)
	{
		inFile = iFile;
		outFile = oFile;
		max = 0;
		count = 0;
		
	}
void Lab8Helper::PrintData()
{
	for (int i = 0; i < this->data.size(); i++)
	{
		cout << this->data[i] << endl;
	}
}



Lab8Helper::~Lab8Helper()
{
}

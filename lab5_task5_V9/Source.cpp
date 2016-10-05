#include <iostream>
#include <vector>
using namespace std;

void main()
{
	vector<int> data;
	int tmp = 0;
	int max = 0;
	int count = 0;
	for (int i = 0; i < 5; i++)
	{
		cin >> tmp;
		data.push_back(tmp);
	}
	for (int i = 0; i < 5; i++)
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
	cout << "max value = " << max << " count = " << count << endl;
}
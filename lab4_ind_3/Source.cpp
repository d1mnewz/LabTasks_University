#include <iostream>
using namespace std; 
void main()
{
	int N = 0;
	int max = 0;
	int index = 0;
	int tmp = 0;
	cout << "ki17 lab4 ind V9 task3" << endl;
	cin >> N;
	if (N > 0)
	{
		for (int i = 0; i < N; i++)
		{
			cin >> tmp;
			if (tmp > max)
			{
				max = tmp;
				index = i;
			}
		}
		cout << max << "index " << index << endl;
	}
}


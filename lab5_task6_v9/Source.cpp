#include <iostream>
#include <vector>
using namespace std;
void p(vector<vector<int>> matrix)
{
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
			cout << matrix[i][j] << "\t";
		cout << endl;

	}
}
void main0()
{
	int count = 0;
	vector<vector<int>> matrix(9);
	for (int i = 0; i < 5; i++)
		matrix[i].resize(5);
	for (int i = 0; i < 5; i++)
	{
		for (int j = 0; j < 5; j++)
		{
			matrix[i][j] = count;
			count++;

		}
	}
	p(matrix);
	
}
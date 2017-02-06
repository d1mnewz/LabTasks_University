#include <iostream>
#include <vector>
#include <time.h>

using namespace std;
void Print(int * arr, int size)
{
	for (int i = 0; i < size; i++)
	{
		cout << arr[i] << "  ";
	}
	cout << endl;
}
void PrintV(vector<int> arr)
{
	size_t size = arr.size();
	for (int i = 0; i < size; i++)
	{
		cout << arr[i] << "  ";
	}
}
int * setNullsInFirst(int *arr, int size)
{
	for (int i = 0; i < size; i++)
	{
		arr[i] = 0;
	}
	return arr;
}
vector<int> InitV(vector<int> v)
{
	int size = rand() % 20;
	for (int i = 0; i < size; i++)
	{
		v.push_back(rand() % 100000);
	}
	return v;
}
void main()
{
	srand(time(NULL));

	int first[11] = { 7,7,7,7,7,7,7,7,7,7,7 };

	int second[14] = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, -1, -2 };

	int third[16] = { -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

	int fourth[23] = { -3, 4, 33, 22, 9, -100, 2, 56, 57, 55, 2, 90, 2234, 32, 8, 123, 2, 33, 22, 22, 33, -1, -3 };

	vector<int> fifth;
	fifth = InitV(fifth);

	cout << "KI-17 Lab 5" << endl;

	Print(first, 11);
	Print(second, 14);
	Print(third, 16);
	Print(fourth, 23);
	Print(setNullsInFirst(first, 11), 11);
	PrintV(fifth);


}
#include <stdio.h>
#include <conio.h>
#define n 9
int main()
{
	int arr[n][n]; 
	int i, j;
	i = n - 1;
	j = 0;
	for (int num = 1; num <= n*n; num++) 
	{
		arr[i][j] = num;
						
						
		int i0, j0;

		i0 = i;
		j0 = j;

		if ((i != 0) && (j != 0))
		{
			i--;
			j--;
		}
		else if ((j == 0) && (i == 0))
		{
			i = n - 2;
			j = n - 1;
		}
		else if (j == 0)
		{
			j = n - i0;
			i = n - 1;
		}
		else 
		{
			i = n - 2 - j0;
			j = n - 1;
		}
	}
	puts("Result Array:");
	for (i = 0; i < n; i++)
	{
		for (j = 0; j < n; j++)
		{
			printf("%4d", arr[i][j]);
		}
		printf("\n");
	}
	return 0;
}
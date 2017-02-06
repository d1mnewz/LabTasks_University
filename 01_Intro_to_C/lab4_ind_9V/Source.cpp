#include <iostream>
#include <math.h>
using namespace std;
void main()
{
	double result = 1;
	for (double i = 0.1; i < 10; i += 0.1)
	{
		result *= 1 + sin(i);
		//cout << result << endl;
	}
	cout << result << endl;
}
//(1+ sin0.1)(1+sin0.2)
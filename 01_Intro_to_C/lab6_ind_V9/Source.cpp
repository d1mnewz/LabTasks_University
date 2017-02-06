
#include <iostream>
#include <string>
using namespace std;
int main()
{
	char s[256];
	int res = 0;
	int k = 0;
	cout << "Input:" << endl;
	cin.getline(s, 256);
	for (int i = 0; i < 256; i++)
	{
		if (s[i+1] == '\0' && s[i] == '.')
		{
			if (k == 3)
				res++;
			break;
		}
		if (s[i] == 'a')
		{
			k++;
		}
		//else if (s[i] == ' ') if the separator is ' ' space
		else if (s[i] == ',')
		{

			if (k == 3)     
				res++;
			k = 0;
		}
	}
	cout << "Result: " << res << endl;
	
	return 0;
}
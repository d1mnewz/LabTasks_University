#include <iostream>
#include <string>
#pragma region DEFINES
#define SOME_DOUBLE 42.424242
#define SOME_INT 424242
#pragma endregion
using namespace std;
void main()
{
	string some_string = "C++ hello xd";
	char input = 0;
	cout << "\tKI-17\t\n";
	cout << "This is some kind of test you know :)" << endl;
	cout << "Wanna see some good stuff right here? " << endl;
	cout << "Type Y if you do" << endl;
	input = getchar();
	if (input == 'y' || input == 'Y')
	{
		cout << "\t" << some_string << "\t " << endl;
		cout << "\t" << SOME_INT    << "\t"  << endl;
		printf("\t%.5f\t\n", SOME_DOUBLE);
		//cout << "\t" << SOME_DOUBLE << "\t" << endl;

		cout << "Lets change some variables. some_string = ";
		cin >> some_string;
		cout << "Fast check. Some string is " << some_string << endl;

	}
	else cout << "Well, something is wrong. Try again later." << endl;
	
}
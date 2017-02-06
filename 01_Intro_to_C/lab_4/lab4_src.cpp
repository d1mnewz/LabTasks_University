#include <iostream>
#include <vector>
#include <string>
#include <time.h>
using namespace std;
void main()
{
	srand(time(NULL));
	vector<string> content{ "My butt does not deserve a website." ,
							"I will not dance on anyone's grave",
							"I cannot hire a substitute student.",
							"Fire is not the cleanser.",
							"Vampire is not a career choice.",
							"Fish do not like coffee." };
	int number = rand() % content.size() + 1;
	cout << "KI-17 Lab 4" << endl;
	cout << "\tBart_simpson.jpg\t" << endl;
	
	for (int i = 0; i < 10; i++)
	{
		cout << content.at(number) << endl;
	}
	
	cout << endl << endl;
	int i = 0;
	number = rand() % content.size() + 1;
	while (i < 10)
	{
		cout << content.at(number) << endl;
		i++;
	}
	cout << endl << endl;

}
#include <iostream>
#include <string>
#include <cctype>

using namespace std;


int CountWords(const char* str)
{
	if (str == NULL)
		return 0;

	bool inSpaces = true;
	int numWords = 0;

	while (*str != NULL)
	{
		if (isspace(*str))
		{
			inSpaces = true;
		}
		else if (inSpaces)
		{
			numWords++;
			inSpaces = false;
		}

		++str;
	}

	return numWords;
}
void main()
{
	char str1[64] = "KI-17";
	char str2[] = " Lab 6.";
	char *str3;
	char str[64];

	char* s_string = "ki17 lab6 string test xddd";

	strcat_s(str1, str2);
	cout << str1 << endl;
	cout << strstr(str1, "17") << endl;// searches for '17' in str1 and prints starting from it
	str3 = strstr(str1, "."); // searches for dot and replaces it with '!'; str3 now is '.'
	strncpy(str3, "!", 1); // searches for dot and replaces it with '!' str3 now is '!'
	cout << str1 << endl;
	cout << str3 << endl;

	strcpy(str, "memset test :)"); // setting first 6 chars to '$'
	cout << str << endl;
	memset(str, '$', 6);
	cout << str << endl;
	cout << endl;

	cout << s_string << endl;
	cout << "Count of words in this string is " << CountWords(s_string) << endl;
}
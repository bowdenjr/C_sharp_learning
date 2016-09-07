// ConsoleApplication8.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

int main()
{
	int v1 = 0, v2 = 0;
	std::cout << "Please enter 2 values in ascending order, I will list the integers between them." << std::endl;
	std::cout << "Value 1 = ";
	std::cin >> v1;
	std::cout << "Value 2 = ";
	std::cin >> v2;

	while (v2-1 > v1)
	{
		//start with v1 and list integers until v2-1 (ie this procedure is not inclusive of the above inputs
		v1++;
		std::cout << v1 << std::endl;
	}
	
	return 0;
}


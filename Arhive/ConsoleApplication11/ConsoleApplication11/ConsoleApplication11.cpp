// ConsoleApplication11.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

int main()
{
	int v1 = 0, v2 = 0, sum = 0;
	std::cout << "Please enter two values" << std::endl;
	std::cin >> v1 >> v2;
	std::cout << "Here are you values" << std::endl;
	v1++;
	for (v1; v2 > v1; ++v1)

		std::cout << (v1) << std::endl;
		
	return 0;
}


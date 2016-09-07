// ConsoleApplication7.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

int main()
{
	int i = 10;
	std::cout << "Here follows the numbers from 10 to 0." << std::endl;
	while (i >= 0)
	{
		std::cout << i << std::endl;
		i--;
	}


    return 0;
}


// ConsoleApplication10.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

int main()
{
	int sum=0;
	for (int v1 = 50; v1 <= 100; ++v1)
		sum += v1;
	std::cout << sum;
    return 0;
}


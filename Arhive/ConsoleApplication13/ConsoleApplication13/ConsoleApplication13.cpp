// ConsoleApplication13.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

int main()
{
	int currVal = 0, val = 0;
	if (std::cin >> currVal) //checks for input
	{
		int cnt = 1; //start counter at 1
		while (std::cin >> val) //read numbers
		{
			if (val == currVal) //if the same then add 1
				++cnt;
			else //different number now, print output
			{
				if (cnt != 1)
				{
					std::cout << currVal << " occurs "
						<< cnt << " times " << std::endl;
				}
				currVal = val; //reset
				cnt = 1; //reset
				}
		}
		
		std::cout << currVal << " occurs "
			<< cnt << " times " << std::endl;
		
	}
	
	
	return 0;
}


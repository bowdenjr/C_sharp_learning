// ConsoleApplication6.cpp : Defines the entry point for the console application.
//

#include <iostream>


int main()
{
	double sum = 0, val = 50;
	//keep executing the while as long as cal is <= 10
	while (val <= 100 ) 
	{
		sum += val; //assigns sum + val to sum
		++val;      //add 1 to val
	}
	std::cout	<< "Sum of 50 to 100 inclusive is " 
				<< sum 
				<< std::endl;
    return 0;
}

 
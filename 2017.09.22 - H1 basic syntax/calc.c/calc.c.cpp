// calc.c.cpp : Defines the entry point for the console application.
//

#include <stdio.h>


int main()
{
	char operatorr;
	double firstNumber, secondNumber;

	printf("Enter an operator (+, -, *,): ");
	scanf("%c", &operatorr);

	printf("Enter two operands: ");
	scanf("%lf %lf", &firstNumber, &secondNumber);

	switch (operatorr)
	{
	case '+':
		printf("%.1lf + %.1lf = %.1lf", firstNumber, secondNumber, firstNumber + secondNumber);
		break;

	case '-':
		printf("%.1lf - %.1lf = %.1lf", firstNumber, secondNumber, firstNumber - secondNumber);
		break;

	case '*':
		printf("%.1lf * %.1lf = %.1lf", firstNumber, secondNumber, firstNumber * secondNumber);
		break;

	case '/':
		printf("%.1lf / %.1lf = %.1lf", firstNumber, secondNumber, firstNumber / secondNumber);
		break;

		// operator doesn't match any case constant (+, -, *, /)
	default:
		printf("Error! operator is not correct");
	}

    return 0;
}


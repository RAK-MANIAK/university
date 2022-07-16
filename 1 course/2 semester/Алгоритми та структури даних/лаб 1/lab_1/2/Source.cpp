#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <windows.h>
#include <math.h>
#include <conio.h>

union binary {
	signed short number_binary;
	struct {
		unsigned char zero : 1;
		unsigned char one : 1;
		unsigned char two : 1;
		unsigned char three : 1;
		unsigned char four : 1;
		unsigned char five : 1;
		unsigned char six : 1;
		unsigned char seven : 1;
		unsigned char eight : 1;
		unsigned char nine : 1;
		unsigned char ten : 1;
		unsigned char eleven : 1;
		unsigned char twelve : 1;
		unsigned char thirteen : 1;
		unsigned char fourteen : 1;
		unsigned char fiveteen : 1;
	}bytes;
};


int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	signed short num;
	binary binary;
	do {
		printf("\n\nДля закінчення програми введіть 0.\nВведіть ціле значення  = "); 
		scanf("%d", &num);
		
		binary.number_binary = num;

		if (binary.bytes.fiveteen == 1) {
			printf("\nЧисло %d є від'ємним, бо знаковий біт = %d.", binary.number_binary, binary.bytes.fiveteen);
		}
		else {
			printf("\nЧисло %d є додатнім, бо знаковий біт = %d.", binary.number_binary, binary.bytes.fiveteen);
		}
	} while (num != 0);
	return 0;
}
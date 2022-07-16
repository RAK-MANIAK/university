#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <math.h>
#include <Windows.h>
#include <string.h>
#include <conio.h>
#include <time.h>

struct ch {
	signed char a = 5;
	signed char b = 127;
	signed char c = 2;
	signed char d = -3;
	signed char f = -120;
	signed char e = -34;
	signed char g = -5;
	signed char l = 56;
	signed char k = 38;
	signed char rez;
}x;
int main() {
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	x.rez = x.a + x.b;
	printf("5+127=%d", x.rez);
	printf("\nВиходить за межі значень типу signed char");
	x.rez = 0;
	x.rez = x.c + x.d;
	printf("\n\n2-3=%d", x.rez);
	printf("\nНе виходить за межі значень типу signed char");
	x.rez = 0;
	x.rez = x.f + x.e;
	printf("\n\n-120-34=%d", x.rez);
	printf("\nВиходить за межі значень типу signed char");
	x.rez = 0;
	x.rez = (unsigned char)(x.g);
	printf("\n\nunsigned char -5=%d", x.rez);
	printf("\nНічого не відбувається");
	x.rez = 0;
	x.rez = x.l & x.k;
	printf("\n\n56 & 38=%d", x.rez);
	printf("\nЛогічна дія AND");
	x.rez = 0;
	x.rez = x.l | x.k;
	printf("\n\n56 | 38=%d", x.rez);
	printf("\nЛогічна дія OR\n");

	return 0;
}
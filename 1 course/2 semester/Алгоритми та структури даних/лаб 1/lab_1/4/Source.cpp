#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <math.h>
#include <Windows.h>
#include <string.h>
#include <conio.h>
#include <time.h>

union radiance {
    float number;
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
        unsigned char sixteen : 1;
        unsigned char seventeen : 1;
        unsigned char eighteen : 1;
        unsigned char nineteen : 1;
        unsigned char twenty : 1;
        unsigned char twenty_one : 1;
        unsigned char twenty_two : 1;
        unsigned char twenty_three : 1;
        unsigned char twenty_four : 1;
        unsigned char twenty_five : 1;
        unsigned char twenty_six : 1;
        unsigned char twenty_seven : 1;
        unsigned char twenty_eight : 1;
        unsigned char twenty_nine : 1;
        unsigned char thirty : 1;
        unsigned char thirty_one : 1;
    }bytes;
}radiance;
int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    printf("¬вед≥ть зм≥нну = "); scanf("%f", &radiance.number);
    printf("\n«наченн€ побитово:\n");
    printf("|%d|%d %d %d %d %d %d %d %d|%d %d %d %d %d %d %d %d %d %d %d %d %d %d %d % d % d % d % d % d % d % d % d | \n", radiance.bytes.thirty_one, radiance.bytes.thirty,radiance.bytes.twenty_nine, radiance.bytes.twenty_eight,radiance.bytes.twenty_seven, radiance.bytes.twenty_six,radiance.bytes.twenty_five, radiance.bytes.twenty_four,radiance.bytes.twenty_three, radiance.bytes.twenty_two,radiance.bytes.twenty_one, radiance.bytes.twenty, radiance.bytes.nineteen,radiance.bytes.eighteen, radiance.bytes.seventeen, radiance.bytes.sixteen,radiance.bytes.fiveteen, radiance.bytes.fourteen, radiance.bytes.thirteen,radiance.bytes.twelve, radiance.bytes.eleven, radiance.bytes.ten,radiance.bytes.nine, radiance.bytes.eight, radiance.bytes.seven,radiance.bytes.six, radiance.bytes.five, radiance.bytes.four,radiance.bytes.three, radiance.bytes.two, radiance.bytes.one,radiance.bytes.zero);
    printf(" |           |                                          |\n");
    printf("знак      ступ≥нь                                    мантиса\n");
    printf("\n«наченн€ побайтово:\n");
    printf("|%d %d %d %d %d %d %d %d|%d %d %d %d %d %d %d %d|%d %d %d %d %d %d %d % d | % d % d % d % d % d % d % d % d | \n", radiance.bytes.thirty_one, radiance.bytes.thirty,radiance.bytes.twenty_nine, radiance.bytes.twenty_eight,radiance.bytes.twenty_seven, radiance.bytes.twenty_six,radiance.bytes.twenty_five, radiance.bytes.twenty_four,radiance.bytes.twenty_three, radiance.bytes.twenty_two,radiance.bytes.twenty_one, radiance.bytes.twenty, radiance.bytes.nineteen,radiance.bytes.eighteen, radiance.bytes.seventeen, radiance.bytes.sixteen,radiance.bytes.fiveteen, radiance.bytes.fourteen, radiance.bytes.thirteen,radiance.bytes.twelve, radiance.bytes.eleven, radiance.bytes.ten,radiance.bytes.nine, radiance.bytes.eight, radiance.bytes.seven,radiance.bytes.six, radiance.bytes.five, radiance.bytes.four,radiance.bytes.three, radiance.bytes.two, radiance.bytes.one,radiance.bytes.zero);
    float s;
    printf("\nќб€г пам'€т≥ зм≥нноњ = %d;\nќбс€г пам'€т≥ union = % d.", sizeof(s), sizeof(radiance));

    return 0;
}
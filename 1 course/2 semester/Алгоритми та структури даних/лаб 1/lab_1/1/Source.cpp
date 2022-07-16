#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <windows.h>
#include <stdlib.h>
#include <time.h>

struct date {
    unsigned short Year : 12;
    unsigned short Month : 4;
    unsigned short Day : 5;
    unsigned short Hour : 5;
    unsigned short Min : 6;
    unsigned short Sec : 6;
};
enum dow {
    Mon = 1,
    Tue,
    Wed,
    Thu,
    Fri,
    Sat,
    Sun
};
int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    time_t now = time(0);
    struct date data;
    int y, m, d, h, mm, s;
    char k[20];
    printf("������ ����� ��� ����� ");
    dow doo;
    scanf_s("%d", &doo);
    switch (doo) {
    case Mon:
        strcpy_s(k, "��������");
        break;
    case Tue:
        strcpy_s(k, "³������");
        break;
    case Wed:
        strcpy_s(k, "������");
        break;
    case Thu:
        strcpy_s(k, "������");
        break;
    case Fri:
        strcpy_s(k, "�'������");
        break;
    case Sat:
        strcpy_s(k, "������");
        break;
    case Sun:
        strcpy_s(k, "�����");
        break;
    default:break;
    }
    printf("������ ��:");
    scanf_s("%d", &y);
    printf("������ �����:");
    scanf_s("%d", &m);
    printf("������ ����:");
    scanf_s("%d", &d);
    printf("������ ������:");
    scanf_s("%d", &h);
    printf("������ �������:");
    scanf_s("%d", &mm);
    printf("������ �������:");
    scanf_s("%d", &s);
    data.Year = y;
    data.Month = m;
    data.Day = d;
    data.Hour = h;
    data.Min = mm;
    data.Sec = s;
    time_t rawtime;
    struct tm* timeinfo;
    time(&rawtime);
    timeinfo = localtime(&rawtime);
    printf("%s", asctime(timeinfo));
    printf("%s,   %d.%d.%d  %d:%d:%d", k, data.Day, data.Month, data.Year, data.Hour, data.Min, data.Sec);
    int n1, n2;
    n1 = sizeof(tm);
    n2 = sizeof(date);
    printf("\n����� tm-%d ����� ������ ���������-%d", n1, n2);
    return 0;
}
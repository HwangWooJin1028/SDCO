#include <stdio.h>

int ScanNumber() {
	int year;
	printf("출생 연도를 입력하세요.\n");
	scanf_s("%d", &year);
	return year;
}

int CalculAge(int StartYear, int EndYear) {
	return EndYear - StartYear + 1;
}

void PrintAge(int UserAge) {
	printf("코로나 19가 발생한 당시 한국 나이는 %d세입니다.\n", UserAge);
}
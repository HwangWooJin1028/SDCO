#include <stdio.h>

int ScanNumber() {
	int year;
	printf("��� ������ �Է��ϼ���.\n");
	scanf_s("%d", &year);
	return year;
}

int CalculAge(int StartYear, int EndYear) {
	return EndYear - StartYear + 1;
}

void PrintAge(int UserAge) {
	printf("�ڷγ� 19�� �߻��� ��� �ѱ� ���̴� %d���Դϴ�.\n", UserAge);
}
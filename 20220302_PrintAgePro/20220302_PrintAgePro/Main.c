#include <stdio.h>
#include "app.h"

void main() {
	int COVID19Year = 2019;
	int UserAge = CalculAge(ScanNumber(), COVID19Year);
	PrintAge(UserAge);
}
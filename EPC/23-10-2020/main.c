#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include "calculation.h"
//Enum = Enumeration
enum SortType {
	ASCENDING = 0, 
	DESCENDING = 1
};
int someIntegers[];
int N;

void printResult() {
	int i;
	for(i = 0; i < N; i++){
		printf("Element %d is %d\n", i, someIntegers[i]);
	}
}
void sortAnArray() {
	//sortType = 0 => ascending(small => bigger), 
	//sortType = 1 => descending(big => smaller)	
	enum SortType sortType;
	printf("Enter sort type(0, 1) : \n"); scanf("%d", &sortType);
	printf("Sorting an array\n");
	int temp;
	int i, j;
	bool condition;
	for(i = 0;i < N-1; i++) {
		for(j = i + 1; j < N; j++) {		
			condition = sortType == ASCENDING 
				? condition = someIntegers[i] > someIntegers[j] 
					: someIntegers[i] < someIntegers[j];				
			if(condition == true) {
					temp = someIntegers[i];
					someIntegers[i] = someIntegers[j];
					someIntegers[j] = temp;
				}
		}
	}
	printf("Finish sorting...\n");
}
void inputArray() {
	printf("Enter number of elements : \n"); scanf("%d", &N);
	int i;
	for(i = 0; i < N; i ++){
		printf("Enter element(%d): \n", i); scanf("%d", &someIntegers[i]);
	}
}
void deleteAnElement() {
	int selectedIndex;
	printf("Enter element index: \n"); scanf("%d", &selectedIndex);	
	int i;
	for(i = selectedIndex; i < N-1; i++) {		
		someIntegers[i] = someIntegers[i+1];
	}	
	N--;	
}
void createMenu() {
	int choice;
	do {
		printf("1 - inputArray\n");
		printf("2 - sortAnArray\n");
		printf("3 - printResult\n");
		printf("4 - Delete an element\n");
		printf("5 - Exit\n");
		printf("Enter your choice: \n"); scanf("%d", &choice);
		switch(choice) {
			case 1:
				inputArray();
				break;
			case 2: 
				sortAnArray();
				break;
			case 3: 
				printResult();
				break;
			case 4: 
				deleteAnElement();
				break;
			default:
				break;
		}		
	}while(choice != 5);

}
int main() {
	//Test of moduling in C
	/*
	printf("Test of \"sum\" function");
	printf("Sum 2 and 3 is : %d\n", sum(2,3));
	doNothing();
	*/	
	createMenu();
}

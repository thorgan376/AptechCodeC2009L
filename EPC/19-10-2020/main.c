#include <stdio.h>
#include <stdlib.h>
//global variables
int N;
float numbers[50];
void inputN() {
	printf("Please enter N = \n"); scanf("%d", &N);
	while(N < 0 || N > 50) {
		printf("Please enter N = \n"); scanf("%d", &N);		
	}
}
void inputNItems() {
	int i;
	for(i = 0; i < N; i++){
		printf("Input item %d = \n", i);
		scanf("%f", &numbers[i]);
	}	
}
void printArray() {
	//In ra de kiem tra
	int i;
	for(i = 0; i < N; i++){
		printf("Item %d is : %f\n", i, numbers[i]);
	}
}
float getMaxValue() {
	float max = numbers[0]; 
	int i;//i = iterator = index
	for(i = 0; i < N; i++){
		/*
		if(numbers[i] > max) {
			max = numbers[i]; //co the viet gon hon ?
		}
		*/
		max = (numbers[i] > max) ? numbers[i] : max; //ternary
	}
	return max;
}
float getMinValue() {
	float min = numbers[0]; 
	int i;//i = iterator = index
	for(i = 0; i < N; i++){		
		min = (numbers[i] < min) ? numbers[i] : min; //ternary
	}
	printf("haha");
	//return min;
}
float getMaxEvenPositiveValue(){
	float max = 0.0; int i;
	for(i = 0; i < N; i++){		
		max = (numbers[i] > max && ((int)numbers[i]) % 2 == 0) 
			? numbers[i] : max; //ternary
	}
	return max;
}
void testBreakAndContinue(){
	//important !, continue = bypass, break: quit
	int i;	
	for(i = 0; i < 100; i++){
		if(i % 2 != 0) {
			//continue;
			break;
		}
		printf("i = %d\n", i);
	}
}
void testGoTo() {
	//Donot use in your project !
	int age;
	ENTER_AGAIN: printf("Enter age to come here(must be >=18): ");
	scanf("%d", &age);
	if(age < 18) {
		goto ENTER_AGAIN;
	} else {
		printf("Please come in\n");
	}
}
void createMenu() {
	int choice;	
	while(choice != 7) {
		printf("1. Input N(N from 0 to 50)\n");
		printf("2. Fill data to array(N - items)\n");
		printf("3. Find max value in the array\n");
		printf("4. Find min value in the array\n");
		printf("5. Find max even/positive value in the array\n");
		printf("6. Find min odd/negative value in the array \n");
		printf("7.Exit\n");
		printf("Enter your choice(1-7): \n");
		scanf("%d", &choice);
		if(choice == 1) {
			inputN();
		}else if(choice == 2) {
			inputNItems();
			printArray();
		}else if(choice == 3) {
			float max = getMaxValue();
			printf("Max value is : %0.2f\n\n", max);			
		}else if(choice == 4) {
			float min = getMinValue();
			printf("Min value is : %0.2f\n\n", min);			
		}else if(choice == 5) {
			float max = getMaxEvenPositiveValue();
			printf("MaxEvenPositiveValue is : %0.2f\n\n", max);						
		}else if(choice == 6) {
			printf("Ban chon 6\n");			
		}		
	}	
}
int main() {
	//createMenu();
	//testGoTo();//donot use in your project !
	testBreakAndContinue();
	return 0;
}

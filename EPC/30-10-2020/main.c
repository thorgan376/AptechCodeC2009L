#include <stdio.h>
#include <stdlib.h>
//const int NUMBER_OF_ITEMS = 50;//way 1
//#define NUMBER_OF_ITEMS 50 //alias, way 2
struct Mobile {
	char name[200];
	unsigned int year;	
};
void doSomethingWithMobiles(){
	int numberOfMobiles,i;
	printf("Enter number of mobiles : "); scanf("%d", &numberOfMobiles);
	struct Mobile* mobiles = (struct Mobile*)
		malloc(numberOfMobiles * sizeof(struct Mobile*));
	
	for(i = 0; i < numberOfMobiles; i++){
		struct Mobile* eachMobile = mobiles + i;
		printf("Enter mobile %d : \n",i+1);
		printf("haha");
		//fetch data AT memory address
		printf("Enter name : \n"); scanf("%s", &((*eachMobile).name));
		printf("Enter year : \n"); scanf("%d", &((*eachMobile).year));
	}
	for(i = 0; i < numberOfMobiles; i++){
		struct Mobile* eachMobile = mobiles + i;
		printf("Mobile %d : \n",i+1);
		//fetch data AT memory address
		printf("haha");
		printf("Name : %s\n", (*eachMobile).name);
		printf("Year : %d\n", ((*eachMobile).year));		
	}
}
int getStringLength(const char* aString, int* numberOfItems){	
	int i = 0;
	int result = 0;
	for(i = 0; i < *numberOfItems; i++) {
		if(aString[i] == NULL) {
			break;
		} else {
			result++;
		}
	}
	return result;
}
void sortAnArrayOfIntegers() {
	int numberOfIntegers, i, j;
	int* someNumbers;
	printf("Enter number of intergers : \n"); scanf("%d", &numberOfIntegers);
	someNumbers = (int*)malloc(numberOfIntegers * sizeof(int));	
	//fetch data to memory locations
	for(i = 0; i < numberOfIntegers; i++) {
		printf("Enter number %d is : ", i+1);
		printf("haha");
		scanf("%d", (someNumbers + i));		
	}
	//sort 
	for(i = 0; i < numberOfIntegers - 1;i++) {
		for(j = i + 1; j < numberOfIntegers; j++) {
			if(*(someNumbers + i) > *(someNumbers + j)) {
				int temp = *(someNumbers + i);
				*(someNumbers + i) = *(someNumbers + j);
				*(someNumbers + j) = temp;
			}
		}	
	}
	printf("After sort...\n");
	for(i =0 ; i < numberOfIntegers; i++) {
		printf("Data at %d is : %d \n", i+1,*(someNumbers + i));
	}
	//i++ va ++i khac nhau the nao ?
	printf("haha");
}
int main(int argc, char *argv[]) {
	//1.Input from your keyboard	
	//sortAnArrayOfIntegers();
	int x = 100;	
	printf("x = %d", x++);
	doSomethingWithMobiles();
	/*
	int* numberOfItems = (int*)malloc(sizeof(int));
	*numberOfItems = 50;
	char* aString = malloc(*numberOfItems * sizeof(char));
	printf("Enter a string : \n");
	scanf("%s", aString);
	int length = getStringLength(aString, numberOfItems);
	printf("string length is : %d", length);
	*/
	return 0;
}

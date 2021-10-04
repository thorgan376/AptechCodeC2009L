#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
using namespace std;
//const int NUMBER_OF_ITEMS = 50;//way 1
//#define NUMBER_OF_ITEMS 50 //alias, way 2
struct Mobile {
	char name[200];
	unsigned int year;	
};

void inputMobiles(struct Mobile* mobiles, int numberOfMobiles){		
	for(int i = 0; i < numberOfMobiles; i++){
		struct Mobile* eachMobile = mobiles + i;
		cout<<"Enter mobile %d : \n"<<i+1;		
		//fetch data AT memory address
		cout<<"Enter name :"<<endl; cin>>(*eachMobile).name;
		printf("Enter year : \n"); scanf("%d", &((*eachMobile).year));
	}	
}
void printMobiles(struct Mobile* mobiles, int numberOfMobiles) {	
	for(int i = 0; i < numberOfMobiles; i++){
		struct Mobile* eachMobile = mobiles + i;
		printf("haha result \n");
		printf("Mobile %d : \n",i+1);
		//fetch data AT memory address		
		printf("Name : %s\n", (*eachMobile).name);
		printf("Year : %d\n", ((*eachMobile).year));		
	}
}
void sortMobilesByYear(struct Mobile* mobiles, int numberOfMobiles) {
	int j;
	for(int i = 0; i < numberOfMobiles - 1; i++) {
		for(j = i + 1; j < numberOfMobiles; j++) {
			//if((*(mobiles + i)).year <  (*(mobiles + j)).year) {						
			if(strcmp((*(mobiles + i)).name, (*(mobiles + j)).name) > 0) {
				struct Mobile temp = *(mobiles + i);				
				temp = *(mobiles + i);
				*(mobiles + i) = *(mobiles + j);
				*(mobiles + j) = temp;
			}			
		}	
	}
}
int main(int argc, char *argv[]) {	
	int numberOfMobiles;
	struct Mobile* mobiles;
	printf("Enter number of mobiles : "); scanf("%d", &numberOfMobiles);
	mobiles = (struct Mobile*) malloc(numberOfMobiles * sizeof(struct Mobile*));
	inputMobiles(mobiles,numberOfMobiles );
	sortMobilesByYear(mobiles, numberOfMobiles);
	printMobiles(mobiles, numberOfMobiles);
	return 0;
}




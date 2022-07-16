#include <stdio.h>
#include <stdlib.h>


typedef int elemtype;
struct elem {
    elemtype value;
    struct elem* next;
    struct elem* prev;
};
struct myList {
    struct elem* head;
    struct elem* tail;
    int size;
};
typedef struct elem cNode;
typedef struct myList cList;

cList* createList(void) {
    cList* list = (cList*)malloc(sizeof(cList));
    if (list) {
        list->size = 0;
        list->head = list->tail = NULL;
    }
    return list;
}
bool isEmptyList(cList* list) {
    return ((list->head == NULL) || (list->tail == NULL));
}

cNode* getNode(cList* list, int index) {
    cNode* node = NULL;
    int i;
    if (index >= list->size) {
        return (NULL);
    }
    if (index < list->size / 2) {
        i = 0;
        node = list->head;
        while (node && i < index) {
            node = node->next;
            i++;
        }
    }
    else {
        i = list->size - 1;
        node = list->tail;
        while (node && i > index) {
            node = node->prev;
            i--;
        }
    }
    return node;
}

int pushFront(cList* list, elemtype* data) {
    cNode* node = (cNode*)malloc(sizeof(cNode));
    if (!node) {
        return(-1);
    }
    node->value = *data;
    node->next = list->head;
    node->prev = NULL;
    if (!isEmptyList(list)) {
        list->head->prev = node;
    }
    else {
        list->tail = node;
    }
    list->head = node;
    list->size++;
    return(0);
}

int pushBack(cList* list, elemtype* data) {
    cNode* node = (cNode*)malloc(sizeof(cNode));
    if (!node) {
        return(-3);
    }
    node->value = *data;
    node->next = NULL;
    node->prev = list->tail;
    if (!isEmptyList(list)) {
        list->tail->next = node;
    }
    else {
        list->head = node;
    }
    list->tail = node;
    list->size++;
    return(0);
}



int pushPosition(cList* list, elemtype* data)
{
   int index = (int)(list->size / 2);
    if (index == 0)

    {
        return pushFront(list, data);
    }
    if (index<0 || index>list->size - 1)
    {
        return -1;
    }
    cNode* next = getNode(list, index - 1)->next;
    cNode* prev = getNode(list, index)->prev;
    cNode* node = (cNode*)malloc(sizeof(cNode));
    node->value = *data;
    getNode(list, index - 1)->next = node;
    getNode(list, index)->prev = node;
    node->next = next;
    node->prev = prev;
    list->size++;
}


int popFront(cList* list) {
    cNode* node;
    if (isEmptyList(list)) {
        return(-2);
    }
    node = list->head;
    list->head = list->head->next;
    if (!isEmptyList(list)) {
        list->head->prev = NULL;
    }
    else {
        list->tail = NULL;
    }
    list->size--;
    free(node);
    return(0);
}int popBack(cList* list) {
    cNode* node = NULL;
    if (isEmptyList(list)) {
        return(-4);
    }
    node = list->tail;
    list->tail = list->tail->prev;
    if (!isEmptyList(list)) {
        list->tail->next = NULL;
    }
    else {
        list->head = NULL;
    }
    list->size--;
    free(node);
    return(0);
}

int popPosition(cList* list)
{
    int index = (int)(list->size / 2);
    if (index == 0)
    {
        elemtype tmp;
        return popFront(list);
    }
    if (index == list->size - 1)
    {
        elemtype tmp;
        return popBack(list);
    }
    if (index<0 || index>list->size - 1)
    {
        return -1;
    }
    cNode* next = getNode(list, index)->next;
    cNode* prev = getNode(list, index)->prev;
    free(getNode(list, index));
    getNode(list, index - 1)->next = next;
    getNode(list, index + 1)->prev = prev;
    list->size--;
    return 0;
}


void printList(myList* numbers) {
    if(!isEmptyList(numbers)){
        cNode* node = numbers->head;
        for(int i = 1; i <= numbers->size; i++){
            printf("\n%i. %i", i, node->value);
            node = node->next;
        }
    } else {
        printf("Список пустий");
    }
}

int main()
{
    system("chcp 1251");
    system("cls");
    createList();
    int x = 0;
    elemtype first = 1;
    elemtype second = 2;
    elemtype third = 3;
    elemtype tmp;

    cList* list = createList();


    do {
        printList(list);

        printf("\n\n1)додавання елемента на початої списку (1)\n");
        printf("2)додавання елемента в середину списку (2)\n");
        printf("3)додавання елемента в кінець списку (3)\n");
        printf("4)видалення елемента з початку списку\n");
        printf("5)видалення елемента з середини списку\n");
        printf("6)видалення елемента з кінця списку\n");
        printf("Введіть дію: ");
        scanf_s("%d", &x);
        switch (x)
        {
        case 1:
            pushFront(list, &first);
            break;
        case 2:
            pushPosition(list, &second);
            break;
        case 3:
            pushBack(list, &third);
            break;
        case 4:
            popFront(list);
            break;
        case 5:
            popPosition(list);
            break;
        case 6:
            popBack(list);
            break;
        default:
            x = -1;
            break;
        }
    } while (x != -1);
    return 0;
}
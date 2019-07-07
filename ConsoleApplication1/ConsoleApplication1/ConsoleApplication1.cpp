// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <sstream>
using namespace std;

typedef struct nodo {
	string elemento;
	struct nodo* link;
};
typedef struct nodo* lista;

void crearLista(lista &l)
{
	int cantidadElementos;
	string elemento;
	bool flagCantidad = false;
	while (!flagCantidad)
	{
		cout << "Ingrese cantidad de elementos: ";
		cin >> cantidadElementos;
		if (!(cantidadElementos > 0))
		{
			cout << "\nERROR. Ingrese un numero mayor a 0.\n\n";
			flagCantidad = false;
		}
		else
			flagCantidad = true;

	}

	lista p;
	p = l;
	for (int i = 1; i <= cantidadElementos; i++)
	{
		bool flag = true;
		while (flag) // Verigicar Nota 1
		{
			cout << "Ingrese elemento " << i << " : ";
			getline(cin,elemento);
			if (elemento == "")
			{
				flag = false;
			}
			else
			{
				cout << "\nNo puede ser vacio el elemento.\n\n";
				flag = true;
			}
		}

		p = new(nodo);
		p->elemento = i;
		p->link = l;

		l = p;
	}
}

void imprimir(lista l)
{
	lista q;
	q = l;
	while (q != NULL)
	{
		cout << "Lista " << q->elemento << endl;
		q = q->link;
	}
}


int main()
{
	
	int nEstados=0, nLenguaje, nEstadosFinales;
	string estadoInicial;
	/*cout << "Ingrese cantidad de ESTADOS: "; cin >> nEstados;
	cout << "\nIngrese cantidad de caracteres del LENGUAJE: "; cin >> nLenguaje;
	cout << "\nIngrese Ingrese cantidad de ESTADOS FINALES: "; cin >> nEstadosFinales;
	cout << "Ingrese ESTADO INICIAL: "; getline(cin, estadoInicial);*/

	lista hola;
	crearLista(hola);
	imprimir(hola);
	


    return 0;
}


using TestesUnitarios.Desafio.Console.Services;
using System;
using System.Collections.Generic;
using System.Linq;


ValidacoesLista lista = new ValidacoesLista();

// Utilizando métodos da Classe ValidacoesLista

List<int> originalLista = new List<int> {1, -2, 3, -4, 5};
List<int> listaSemNegativos = lista.RemoverNumerosNegativos(originalLista);
List<int> listaMultiplicada = lista.MultiplicarNumerosLista(listaSemNegativos, 2);

Console.WriteLine("Lista Original: " + string.Join(", ", originalLista));
Console.WriteLine("Lista sem números negativos: " + string.Join(", ", listaSemNegativos));

Console.WriteLine($"Lista Multiplicada por 2: {string.Join(", ", listaMultiplicada)}");

int maiorNumero = lista.RetornarMaiorNumeroLista(originalLista);
Console.WriteLine($"Maior Número da lista: {maiorNumero}");

int menorNumero = lista.RetornarMenorNumeroLista(originalLista);
Console.WriteLine($"Menor Número da lista: {menorNumero}");


programa
{
	
	funcao inicio()
	{
		real produto1, produto2, produto3, totalLitros

		escreva("Quantidade de latas:")
		leia(produto1)
		produto1 = (produto1*0.350)

		escreva("Quantidade de garrafas de 600 ml:")
		leia(produto2)
		produto2 = (produto1*0.600)

		escreva("Quantidade de latas:")
		leia(produto3)
		produto3 = (produto3*2)
		totalLitros = produto1 + produto2 + produto3
		escreva("O total em litros é: ", totalLitros)
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 446; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
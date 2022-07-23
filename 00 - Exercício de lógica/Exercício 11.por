programa
{
	
	funcao inicio()
	{
		inteiro quantCavalo
		real unidFerradura, desconto, total
		unidFerradura = 9.90
	
		escreva("Qual a quantidade de cavalos?")
		leia (quantCavalo)
		total = (unidFerradura * quantCavalo)*4
		escreva("O valor é: ", total + "\n")
		
		se(total >= 100)
		{
			desconto = total - 0.10
			escreva("Aplicado 10% de desconto! Valor total: ", desconto)
		}senao 
		{
			escreva("Compra realizada com sucesso!")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 398; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */
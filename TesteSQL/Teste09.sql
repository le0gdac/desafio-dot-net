SELECT
	[NOME] AS [Nome do Aluno], 
	[NOTA SEMESTRE 1] AS [Nota do Primeiro Semestre], 
	[NOTA SEMESTRE 2] AS [Nota do Segundo Semestre], 
	[MEDIA] AS [M�dia Anual],
	[ANO] AS [Ano],
	[STATUS] AS [Status]
FROM [ALUNOS] WHERE [MEDIA] > 6;
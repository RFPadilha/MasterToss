# “Knife Hit” Clone

## Descrição do jogo Original:
- “Tap” na tela, ou clique pra arremessar a faca na vertical (unica interação do jogador)


- Alvo redondo e giratório deve receber todas as facas para passar de fase
- Ao passar de fase, fases ficam mais dificeis
    - Inicia com obstaculos
    - padrão de giro mais errático
    - mais facas para arremessar
    
- HUD
    - Munição a esquerda
    - Facas arremessadas no canto superior esquerdo
    - Maçãs acertadas no canto superior direito
    - Progresso de fase e BOSS em cima no meio
    
- Perde jogo ao acertar uma faca ao inves do alvo
- Ao perder, retorna para a primeira fase
- Ao derrotar um BOSS, ganha xp e facas novas


## Descrição dos scripts
A seguir, todos os scripts implementados
- Script do jogador
    - Ao receber input, impõe velocidade vertical em uma instância da faca
        - também ajusta o contador de facas
        
- Script da faca
    - Permanece com o alvo, girando de acordo
        - problemas com joints e colisões
        - resolvido mudando o “parent object” da faca
    - Arremessar múltiplas facas
        - resolvido instanciando facas novas com input
    - Ao colidir com outra faca, encerra o jogo
    - Determina quando passa de fase ao esgotar as facas
    - Efeitos sonoros ao acertar objetos diferentes


- Script do alvo:
    - Girar por uma quantidade aleatória de tempo, invertendo direções
        - resolvido com System.Random()
        - inverte aleatoriamente baseado em um dado de 100 lados
    - Iniciar com quantidade aleatória de facas/maçãs
        - problemas em encontrar a angulação/posição correta das facas (17:00+)
        - resolvido manualmente(19:15)


- Script da maçã
    - Objeto destrutível
    - Gira de acordo com o alvo que está preso
    - Pontuação no HUD


- Script do HUD
    - Pontuação conforme as facas permanecem no alvo
        - feito com script que controla o texto no HUD
    - Contador de alvos destruídos (contador de fases)
    - Pontuação de maçãs, conforme elas são destruídas
        - feito com detecção de colisões
    - Munição de facas conforme jogador as atira
    
- To fix
    - Faca girando após acertar maçã
        - feito transformando o colisor da maçã em trigger
    - Tela de game over
    - Alvo que não parece um alvo
        - transformado em 2d, usando sprite de alvo
    - Sons e imagens melhores
        - terminado de editar a faixa de som
        
## Toques Finais
- Conseguir novas imagens
    - Alvo
    - Faca adequada
    - Backgrounds
- Ajustar textos e layout
    - Main menu
    - In-game
    - Game over
    - Botões
- Música de fundo
    - In-game
        
## Relatório de progresso:

27/08/2020:

- 12:30 - respondido o e-mail, início do projeto
- 14:30 - término do set-up, com os objetos base e o repositório no github, interrupção no processo
- 16:00 - continuação, início dos scripts
- 19:10 - término das atividades do dia
    - script da faca completo
    - script da maçã completo
    
    - script do HUD incompleto
        - resta o contador de fases/boss
    - script do alvo incompleto
        - resta iniciar com quantidades aleatórias de facas e maçãs
    - resta encerrar o jogo e avançar de fase
    - resta implementar menu
    - resta efeitos de “game feel” (audio, visual effects, etc…)
        - processo interrompido durante o scripting de “camera shake”

28/08/2020

- 11:04 - retomada do desenvolvimento, adicionados efeitos de som
- 12:16 - tentativa de implementar vibração na câmera ao acertar a faca, funciona só na primeira por enquanto
- 12:35 - consertado o problema com encerrar o jogo ao acertar outra faca
- 13:00 - implementado menu inicial, e menu de opções (atualmente só ajusta o volume)
- 13:10 - inserido música de fundo
- 13:30 - audios ajustados para responder ao controle de volume no menu inicial
- 14:30 - terminado alguns bug fixes, interrupção no processo
- 16:00 - retomada do desenvolvimento, corrigidos erros na tela de game over
- 19:18 - limpando código desnecessário e ajustes finais
- 20:57 - Ajustes de áudio finalizados
- 21:54 - Ajustes finais encerrados
    




# MasterToss
Knife Hit clone game


## Descrição do jogo original:
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
- Script do jogador
    - (DONE) ao receber input, impõe velocidade vertical em uma instância da faca
        - também ajusta o contador de facas
        
- Script da faca
    - (DONE) permanece com o alvo, girando de acordo
        - problemas com joints e colisões
        - resolvido mudando o “parent object” da faca
    - (DONE) arremessar múltiplas facas
        - resolvido instanciando facas novas com input
    - (DONE) ao colidir com outra faca, encerra o jogo
    - (DONE) determina quando passa de fase ao esgotar as facas
    - (DONE) efeitos sonoros ao acertar alvos diferentes
        - maçã
        - alvo
        - outra faca


- Script do alvo:
    - (DONE) girar por uma quantidade aleatória de tempo, invertendo direções
        - resolvido com System.Random()
        - inverte aleatoriamente baseado em um dado de 100 lados
    - (DONE) iniciar com quantidade aleatória de facas/maçãs
        - problemas em encontrar a angulação/posição correta das facas (17:00+)
        - resolvido manualmente(19:15)


- Script da maçã
    - (DONE) objeto destrutível
    - (DONE) gira de acordo com o alvo que está preso
    - (DONE) pontuação no HUD


- Script do HUD
    - (DONE) pontuação conforme as facas permanecem no alvo
        - feito com script que controla o texto no HUD
    - (DONE) contador de alvos destruídos (contador de fases)
    - (DONE) pontuação de maçãs, conforme elas são destruídas
        - feito com detecção de colisões
    - (DONE) munição de facas conforme jogador as atira
    
- To fix
    - (DONE) faca girando após acertar maçã
        - feito transformando o colisor da maçã em trigger
    - (DONE) tela de game over
    - (DONE) alvo que não parece um alvo
        - transformado em 2d, usando sprite de alvo
    - (DONE) sons e imagens melhores
    
    
# Relatório:

27/08/2020:

- 12:30 - respondido o e-mail, início do projeto
- 14:30 - término do set-up, com os objetos base e o repositório no github, interrupção no processo
- 16:00 - continuação, início dos scripts
- 17:00 - script da faca completo
- 17:30 - script da maçã completo
- 19:10 - Interrupção no processo
    - script do HUD incompleto
        - resta o contador de fases/boss
    - script do alvo incompleto
        - resta iniciar com quantidades aleatórias de facas e maçãs
    - resta encerrar o jogo e avançar de fase
    - resta implementar menu
    - resta efeitos de “game feel” (audio, visual effects, etc…)
        - processo interrompido durante o scripting de “camera shake”

28/08/2020

- 11:00 - retomada do desenvolvimento, adicionados efeitos de som
- 12:00 - tentativa de implementar vibração na câmera ao acertar a faca, funciona só na primeira por enquanto
- 12:10 - consertado o problema com encerrar o jogo ao acertar outra faca
- 13:00 - implementado menu inicial, e menu de opções (atualmente só ajusta o volume)
- 13:10 - inserido música de fundo
- 13:30 - audios ajustados para responder ao controle de volume no menu inicial
- 14:30 - terminado alguns bug fixes, interrupção no processo, "camera shake" funciona propriamente
- 16:00 - retomada do desenvolvimento, corrigidos erros na tela de game over
- 19:20 - limpando código desnecessário e ajustes finais

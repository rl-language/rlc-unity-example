
import serialization.to_byte_vector
import string
import action
import learn


cls Board:
    BInt<0, 3>[9] slots
    Bool playerTurn


    fun get(Int x, Int y) -> Int:
        return self.slots[x + (y*3)].value

    fun set(Int x, Int y, Int val): 
        self.slots[x + (y * 3)].value = val

    fun full() -> Bool:
        let x = 0

        while x < 3:
            let y = 0
            while y < 3:
                if self.get(x, y) == 0:
                    return false
                y = y + 1
            x = x + 1

        return true

    fun three_in_a_line_player_row(Int player_id, Int row) -> Bool:
        return self.get(0, row) == self.get(1, row) and self.get(0, row) == self.get(2, row) and self.get(0, row) == player_id

    fun three_in_a_line_player(Int player_id) -> Bool:
        let x = 0
        while x < 3:
            if self.get(x, 0) == self.get(x, 1) and self.get(x, 0) == self.get(x, 2) and self.get(x, 0) == player_id:
                return true

            if self.three_in_a_line_player_row(player_id, x):
                return true
            x = x + 1

        if self.get(0, 0) == self.get(1, 1) and self.get(0, 0) == self.get(2, 2) and self.get(0, 0) == player_id:
            return true

        if self.get(0, 2) == self.get(1, 1) and self.get(0, 2) == self.get(2, 0) and self.get(0, 2) == player_id:
            return true

        return false

    fun current_player() -> Int:
        return int(self.playerTurn) + 1

    fun next_turn():
        self.playerTurn = !self.playerTurn


@classes
act play() -> Game:
    frm board : Board
    while !board.full():
        act mark(BInt<0, 3> x, BInt<0, 3> y) {
            board.get(x.value, y.value) == 0
        }
        board.set(x.value, y.value, board.current_player())

        if x == 2 and !board.full():
            act mark(BInt<0, 3> x, BInt<0, 3> y) {
                board.get(x.value, y.value) == 0
            }
            board.set(x.value, y.value, board.current_player())


        if board.three_in_a_line_player(board.current_player()):
            return
        board.next_turn()

fun get_current_player(Game g) -> Int:
    return int(g.board.playerTurn)

fun score(Game g, Int player_id) -> Float:
    if !g.is_done(): 
        return 0.0 
    if g.board.three_in_a_line_player(player_id + 1):
        return 1.0
    else if g.board.three_in_a_line_player(((player_id + 1)% 2) + 1):
        return -1.0
    return 0.0

fun get_num_players() -> Int:
    return 2

fun fuzz(Vector<Byte> input):
    let state = play()
    let x : AnyGameAction
    let enumeration = enumerate(x)
    let index = 0
    while index + 8 < input.size() and !state.is_done():
        let num_action : Int
        from_byte_vector(num_action, input, index)
        if num_action < 0:
          num_action = num_action * -1 
        if num_action < 0:
          num_action = 0 

        let executable : Vector<AnyGameAction>
        let i = 0
        #print("VALIDS")
        while i < enumeration.size():
          if can apply(enumeration.get(i), state):
            #print(enumeration.get(i))
            executable.append(enumeration.get(i))
          i = i + 1
        #print("ENDVALIDS")
        if executable.size() == 0:
            assert(false, "zero valid actions")

        print(executable.get(num_action % executable.size()))
        apply(executable.get(num_action % executable.size()), state)


fun main() -> Int:
    let game = play()
    let x : BInt<0, 3>
    let y : BInt<0, 3>
    x = 0
    y = 0
    game.mark(x, y)
    if game.board.full():
        return 1
    x = 1
    y = 0
    game.mark(x, y)
    if game.board.full():
        return 2
    x = 1
    y = 1
    game.mark(x, y)
    if game.board.full():
        return 3
    x = 2
    y = 0
    game.mark(x, y)
    if game.board.full():
        return 4
    x = 2
    y = 2
    game.mark(x, y)
    if game.board.full():
        return 5
    if game.board.three_in_a_line_player(1):
        return 0
    else:
        return 1

fun pretty_print(Game g):
    let i = 0
    while i != 3:
        let to_print : String
        let y = 0
        while y != 3:
            to_print.append(to_string(g.board.get(i, y)))
            y = y + 1 
        print(to_print)
        i = i + 1

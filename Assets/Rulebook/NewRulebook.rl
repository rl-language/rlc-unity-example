import serialization.to_byte_vector
import string
import action
import learn
import range
import Fuzzer

cls Board:
    BInt<0, 3>[9] slots
    Bool playerTurn

    fun get(Int x, Int y) -> Int:
        return self.slots[x + (y*3)].value

    fun set(Int x, Int y, Int val): 
        self.slots[x + (y * 3)].value = val

    fun full() -> Bool:
        for x in range(3):
            for y in range(3):
                if self.get(x, y) == 0:
                    return false
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
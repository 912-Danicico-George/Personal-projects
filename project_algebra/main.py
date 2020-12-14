# This is project 7 for Algebra Danicico George-Iulian

# Input for the problem: m,n for a M2,3(Z2)

# Output:
# 1.The number of echelon form matrix of size m,n
# 2. The matrixes in echelon form of size m,n in Z2


# This is the initialisation of the matrix
def init_matrix(sequence):
    sequence = sequence.split(';')
    M = int(sequence[0])
    N = int(sequence[1])
    Matrix = []
    for i in range(M):
        appending_list = []
        for j in range(N):
            appending_list.append(0)
        Matrix.append(appending_list)

    return N, M, Matrix


def print_solution(matrix, n, m, list_of_echelon_matrixes, file_out):

    list_of_echelon_matrixes.append(matrix)
    if n <= 5 and m <= 5:
        for row in matrix:
            file_out.write(str(row) + "\n")

        file_out.write('\n')


def is_valid(matrix, n, k):
    """
    we check if the matrix respects the validation steps
    :param matrix: the current matrix
    :param n: the number of the columns
    :param k: the current index of the element in a way of (column * row)
    :return:
    """
    row = k // n
    if row == 0:
        return True
    column = k % n if k % n != 0 else 0
    if column == 0:
        if matrix[row][column] == 1:
            return False

    previous_row = row - 1
    previous_column = column

    previous_row_value = None
    current_row_value = None

    for i in range(previous_column + 1):
        if matrix[previous_row][i] == 1 and previous_row_value is None:
            previous_row_value = i
        if matrix[row][i] == 1 and current_row_value is None:
            current_row_value = i
            if previous_row_value is None:
                return False
            for reverse_row in range(row):
                if matrix[reverse_row][i] == 1:
                    return False

        if previous_row_value is None and current_row_value is not None:
            return False

    return True


def is_solution(k, n, m):
    """
    if the k reached then of the matrix it means that we have a solution
    :param k: the index of the current element
    :param n: the number of columns
    :param m: the number of the rows
    :return:
    """
    if k == n * m:
        return True
    return False


"""
Now we do a simple backtracking now
"""


def backtracking(matrix, n, m, k, list_of_echelon_matrixes, file_out):
    if is_solution(k, n, m):
        print_solution(matrix, n, m, list_of_echelon_matrixes, file_out)
    else:
        for i in range(2):
            row = k // n
            column = k % n if k % n != 0 else 0
            matrix[row][column] = i
            if is_valid(matrix, n, k):
                backtracking(matrix, n, m, k + 1, list_of_echelon_matrixes, file_out)
                matrix[row][column] = 0


file_in = open("input.txt", 'r')
file_out = open("output.txt", 'w')
file_out.write("Examples result for project 7 - Danicico George-Iulian 912\n")

lines = file_in.readlines()

n, m, matrix = init_matrix(lines[0])
list_of_echelon_matrixes = list()
backtracking(matrix, n, m, 0, list_of_echelon_matrixes, file_out)
file_out.write("\n")
file_out.write(
    f"The number of matrixes ( M{m},{n} in Z2 ) in reduced echelon form is: {len(list_of_echelon_matrixes)}\n")

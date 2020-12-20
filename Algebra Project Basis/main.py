# Project 6 Danicico George-Iulian 912

# Input 2 natural numbers, m, n >= 2 and a matrix A in Mm,n

# Output:
#       1. the dimension of Ker f and Im f  where f: R^n -> R^m is an R-linear map having the matrix A in the pair of the
#       canonical bases of R^n and R^m
#       2. a basis for the above Ker f and Im f.

# this is the generation of the vectors

file_read = open("input.txt", 'r')
file_write = open("output.txt", 'w')


def add_sol(vector, list_of_vectors):
    vector_copy = vector[:]
    list_of_vectors.append(vector_copy)


def is_solution(n, k):
    return k == n


def all_vectors(vector, n, k, list_of_vectors):
    if is_solution(n, k):
        add_sol(vector, list_of_vectors)
    else:
        for i in range(2):
            vector[k] = i
            all_vectors(vector, n, k + 1, list_of_vectors)
            vector[k] = 0


# the implementation above generates all the vectors

def sum_vectors(v1, v2, length):
    v3 = []
    for i in range(length):
        v3.append(0)
        v3[i] = (v1[i] + v2[i]) % 2
    return v3


def check(generated_vectors, generated_space):
    length = len(generated_vectors)
    for gen in generated_space:
        counter = 0
        for element in gen:
            if element in generated_vectors:
                counter += 1
        if counter == length:
            return False
    return True


# this implementation will select all the combinations that form a basis and generates a different subspace
def add_basis(generated_vectors, generated_space, current_basis, list_of_k_dim_basis, dim, length):
    generated_vectors = []
    generated_vectors.append([0] * length)
    generated_vectors.append(current_basis[0])

    # in the implementation below we check if the vectors a linearly independet
    for i in range(1, dim):
        length2 = len(generated_vectors)
        for j in range(length2):
            v3 = sum_vectors(current_basis[i], generated_vectors[j], length)
            if v3 in generated_vectors:
                return None
            if v3 not in generated_vectors:
                generated_vectors.append(v3)

    if check(generated_vectors, generated_space):
        generated_spaces.append(generated_vectors)
        list_of_k_dim_basis.append(current_basis[:])


def is_valid_basis(basis_index, k):
    if k > 0:
        if basis_index[k] <= basis_index[k - 1]:
            return False

    return True


def all_different_basis(generated_vectors, generated_spaces, current_basis, basis_index, list_of_vectors,
                        list_of_k_dim_basis, n, k, dim,
                        length):
    if is_solution(k, dim):
        add_basis(generated_vectors, generated_spaces, current_basis, list_of_k_dim_basis, dim, length)
    else:
        for i in range(n):
            current_basis[k] = list_of_vectors[i][:]
            basis_index[k] = i
            if is_valid_basis(basis_index, k):
                all_different_basis(generated_vectors, generated_spaces, current_basis, basis_index, list_of_vectors,
                                    list_of_k_dim_basis,
                                    n, k + 1, dim, length)
                current_basis[k] = 0
                basis_index[k] = 0


lines = file_read.readlines()
lines = lines[0].split(";")
k = int(lines[0])
n = int(lines[1])
list_of_k_dim_basis = []
list_of_vectors = []
vector = []
current_basis = []
basis_index = []
generated_spaces = []
generated_vectors = []
# vector and basis initialisation
for i in range(n):
    vector.append(0)
for i in range(k):
    current_basis.append(0)
    basis_index.append(0)

all_vectors(vector, n, 0, list_of_vectors)
list_of_vectors = list_of_vectors[1:]

all_different_basis(generated_vectors, generated_spaces, current_basis, basis_index, list_of_vectors,
                    list_of_k_dim_basis, len(list_of_vectors), 0, k, n)
file_write.write("Project 6 Danicico George 912\n")
file_write.write(
    f"The number of {k} dimensional subspaces of the vector space Z2 ^ {n} over Z_2 is: {len(list_of_k_dim_basis)}\n")

file_write.write("A basis of each subspace is: \n")
index = 1
for el in list_of_k_dim_basis:
    file_write.write(str(index) + ". " + str(el) + '\n')
    index += 1
file_write.close()

class Hamming {
    compute(a: string, b: string): number {
        if (a.length !== b.length) {
            throw new Error('DNA strands must be of equal length.')
        }

        return [...a].reduce((acc, value, index) => {
            return value !== b[index] ? acc += 1 : acc
        }, 0)
    }
}

export default Hamming

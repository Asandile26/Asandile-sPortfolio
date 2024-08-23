const sum = (...numbers: number[]): number => {
    return numbers.reduce((total, number) => total + number, 0);
};

export default sum;

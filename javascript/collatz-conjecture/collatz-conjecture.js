export const steps = num => {
  const steps = 0;
  return calculate(num, steps);
};

const calculate = (num, steps) => {
  //   console.log(num, steps);
  if (num === 1) {
    return steps;
  }

  steps += 1;

  if (num % 2 === 0) {
    calculate(num / 2, steps);
  } else {
    calculate(num * 3 + 1, steps);
  }
};

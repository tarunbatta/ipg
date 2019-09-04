module.exports = {
  'env': {
    'browser': true,
    'commonjs': true,
    'es6': true,
  },
  'extends': [
    'google',
    'eslint:recommended'
  ],
  'globals': {
    'Atomics': 'readonly',
    'SharedArrayBuffer': 'readonly',
  },
  'parserOptions': {
    'ecmaVersion': 2018,
  },
  'rules': {
    'eol-last': 'off',
    'indent': ['warn', 4],
    'linebreak-style': [
      'error',
      'windows'
    ],
    'max-len': 'off',
    'new-cap': 'off',
    'no-alert': 'warn',
    'no-console': 'warn',
    'no-dupe-args': 'error',
    'no-eq-null': 'off',
    'no-fallthrough': 'error',
    'no-floating-decimal': 'off',
    'no-global-assign': 'error',
    'no-multi-str': 'off',
    'no-redeclare': 'error',
    'no-sequences': 'off',
    'no-unused-vars': 'off',
    'no-useless-escape': 'off',
    'quotes': [
      'error',
      'single'
    ],
    'require-atomic-updates': 'off',
    'semi': [
      'error',
      'always'
    ],
    'space-before-function-paren': ["warn", "always"],
  },
};
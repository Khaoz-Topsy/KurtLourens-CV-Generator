const path = require('path');
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
const { CleanWebpackPlugin } = require('clean-webpack-plugin');

const bundleFileName = 'bundle';
const dirName = 'wwwroot/dist';

module.exports = (env, argv) => {
	return {
		mode: argv.mode === "production" ? "production" : "development",
		entry: [
			'./webpack/lib/main.js',
			'./webpack/lib/custom.js',
		],
		output: {
			filename: bundleFileName + '.js',
			path: path.resolve(__dirname, dirName),
			library: 'KurtLourens',
			// libraryTarget: 'window'
		},
		module: {
			rules: [
				{
					test: /\.js$/,
					exclude: /(node_modules)/,
					use: {
						loader: 'babel-loader',
						options: {
							presets: ['@babel/preset-env']
						}
					}
				},
				{
					test: /\.(ttf|eot|woff|woff2|svg)$/,
					use: {
						loader: 'file-loader',
						options: {
							name: '[name].[ext]',
							outputPath: 'fonts',
							esModule: false,
						},
					},
				},
				{
					test: /\.s[c|a]ss$/,
					use:
						[
							'style-loader',
							MiniCssExtractPlugin.loader,
							'css-loader',
							'resolve-url-loader',
							'sass-loader'
						]
				}
			]
		},
		plugins: [
			new CleanWebpackPlugin(),
			new MiniCssExtractPlugin({
				filename: bundleFileName + '.css'
			}),
		]
	};
};
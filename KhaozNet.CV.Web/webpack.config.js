const path = require('path');
const glob = require('glob')
const MiniCssExtractPlugin = require("mini-css-extract-plugin");
const { CleanWebpackPlugin } = require('clean-webpack-plugin');
const OptimizeCssAssetsPlugin = require('optimize-css-assets-webpack-plugin');

const bundleFileName = 'bundle';
const dirName = 'wwwroot/dist';
const distPath = path.resolve(__dirname, dirName);

module.exports = (env, argv) => {
	return {
		mode: argv.mode === "production" ? "production" : "development",
		entry: [
			'./webpack/lib/main.js',
			'./webpack/lib/custom.js',
		],
		output: {
			filename: bundleFileName + '.js',
			path: distPath,
			library: 'KurtLourens',
			// libraryTarget: 'window'
		},
		optimization: {
			splitChunks: {
				cacheGroups: {
					styles: {
						name: 'styles',
						test: /\.css$/,
						chunks: 'all',
						enforce: true
					}
				}
			},
			minimizer: [
				new OptimizeCssAssetsPlugin({
					cssProcessorOptions: {
						map: {
							inline: false,
							annotation: true,
						},
					},
				}),
			],
		},
		// devtool: 'source-map',
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
			// new PurgeCSSPlugin({
			// 	paths: glob.sync(`${distPath}/**/*`, { nodir: true }),
			// 	trim: true,
			// 	shorten: true,
			// 	verbose: false,
			// 	content: [
			// 		'./webpack/purgeCssPleaseInclude.html',
			// 		'./Pages/Index.cshtml',
			// 	]
			// }),
		]
	};
};
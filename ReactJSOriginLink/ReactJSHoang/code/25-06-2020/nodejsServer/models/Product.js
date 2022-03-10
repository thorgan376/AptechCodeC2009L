//sequelize-auto 
module.exports = (Sequelize, sequelize) => {
    return sequelize.define('Products', {
        id: {
          type: Sequelize.DataTypes.INTEGER(11),
          allowNull: false,
          primaryKey: true,
          autoIncrement: true
        },
        name: {
          type: Sequelize.DataTypes.STRING(500),
          allowNull: false
        },
        year: {
          type: Sequelize.DataTypes.INTEGER(11),
          allowNull: false
        },        
        description: {
          type: Sequelize.DataTypes.STRING(500),
          allowNull: true
        }
      }, {
        tableName: 'Products',
        timestamps: false,
      });    
}  
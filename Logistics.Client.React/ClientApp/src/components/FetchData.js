import React, { Component } from 'react';

export class FetchData extends Component {
    static displayName = FetchData.name;

    constructor(props) {
        super(props);
        this.state = { shippingItems: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    static renderShipmentTable(shippingItems) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>BoxId</th>
                        <th>PartNumber</th>
                        <th>PartWeight</th>
                        <th>PartCost</th>
                    </tr>
                </thead>
                <tbody>
                    {shippingItems.map(item =>
                        <tr key={item.partNumber}>
                            <td>{item.boxId}</td>
                            <td>{item.partNumber}</td>
                            <td>{item.partWeight}</td>
                            <td>{item.partCost}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchData.renderShipmentTable(this.state.shippingItems);

        return (
            <div>
                <h1 id="tabelLabel" >Weather forecast</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }

    async populateWeatherData() {
        console.log('data')

        const response = await fetch('/logistics/generate', { method: 'POST', data: null });
        console.log('response', response)
        const data = await response.json();
        console.log('response', data)
        
        this.setState({ shippingItems: data, loading: false });
    }
}

/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.InternetMonitor.Model;

namespace Amazon.InternetMonitor
{
    /// <summary>
    /// Interface for accessing InternetMonitor
    ///
    /// Amazon CloudWatch Internet Monitor provides visibility into how internet issues impact
    /// the performance and availability between your applications hosted on Amazon Web Services
    /// and your end users, reducing the time it takes for you to diagnose these issues, from
    /// days to minutes. You can explore internet measurements for different time frames and
    /// at different geographic granularities, and quickly visualize the impact of issues,
    /// and then take action to improve your end users' experience, for example, by switching
    /// to other Amazon Web Services services or rerouting traffic to your workload through
    /// differentAmazon Web Services Regions.
    /// 
    ///  
    /// <para>
    ///  If the issue is caused by the Amazon Web Services network, you'll automatically receive
    /// an Amazon Web Services Health Dashboard notification with the steps that Amazon Web
    /// Services is taking to mitigate the problem. To support integrating health information
    /// for geographies and networks specific to your application, Internet Monitor delivers
    /// measurements to CloudWatch Logs and CloudWatch Metrics. Internet Monitor also sends
    /// health events to Amazon EventBridge, so you can set up notifications. Internet Monitor
    /// monitors internet connectivity for your application through Amazon Virtual Private
    /// Clouds (VPCs), Amazon CloudFront distributions, and Amazon WorkSpaces directories.
    /// </para>
    ///  
    /// <para>
    /// To use Internet Monitor, you create a <i>monitor</i> and add resources to it, Virtual
    /// Private Clouds (VPCs), Amazon CloudFront distributions, or WorkSpaces directories
    /// that show where your application's internet traffic is. Internet Monitor then provides
    /// internet measurements from Amazon Web Services that are specific to the locations
    /// and networks that communicate with your application. For more information, see <a
    /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-InternetMonitor.html">
    /// Using Amazon CloudWatch Internet Monitor</a> in the Amazon CloudWatch User Guide.
    /// </para>
    /// </summary>
    public partial interface IAmazonInternetMonitor : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IInternetMonitorPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateMonitor



        /// <summary>
        /// Creates a monitor in Amazon CloudWatch Internet Monitor. A monitor is built based
        /// on information from the application resources that you add: Virtual Private Clouds
        /// (VPCs), Amazon CloudFront distributions, and WorkSpaces directories. 
        /// 
        ///  
        /// <para>
        /// After you create a monitor, you can view the internet performance for your application,
        /// scoped to a location, as well as any health events that are impairing traffic. Internet
        /// Monitor can also diagnose whether the impairment is on the Amazon Web Services network
        /// or is an issue with an internet service provider (ISP).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ConflictException">
        /// The requested resource is in use.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        Task<CreateMonitorResponse> CreateMonitorAsync(CreateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMonitor



        /// <summary>
        /// Deletes a monitor in Amazon CloudWatch Internet Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        Task<DeleteMonitorResponse> DeleteMonitorAsync(DeleteMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetHealthEvent



        /// <summary>
        /// Gets information the Amazon CloudWatch Internet Monitor has created and stored about
        /// a health event for a specified monitor. This information includes the impacted locations,
        /// and all of the information related to the event by location.
        /// 
        ///  
        /// <para>
        /// The information returned includes the performance, availability, and round-trip time
        /// impact, information about the network providers, the event type, and so on.
        /// </para>
        ///  
        /// <para>
        /// Information rolled up at the global traffic level is also returned, including the
        /// impact type and total traffic impact.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHealthEvent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetHealthEvent service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetHealthEvent">REST API Reference for GetHealthEvent Operation</seealso>
        Task<GetHealthEventResponse> GetHealthEventAsync(GetHealthEventRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMonitor



        /// <summary>
        /// Gets information about a monitor in Amazon CloudWatch Internet Monitor based on a
        /// monitor name. The information returned includes the Amazon Resource Name (ARN), create
        /// time, modified time, resources included in the monitor, and status information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        Task<GetMonitorResponse> GetMonitorAsync(GetMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHealthEvents



        /// <summary>
        /// Lists all health events for a monitor in Amazon CloudWatch Internet Monitor. Returns
        /// all information for health events including the client location information the network
        /// cause and status, event start and end time, percentage of total traffic impacted,
        /// and status.
        /// 
        ///  <note> 
        /// <para>
        /// Health events that have start times during the time frame that is requested are not
        /// included in the list of health events.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHealthEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListHealthEvents service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListHealthEvents">REST API Reference for ListHealthEvents Operation</seealso>
        Task<ListHealthEventsResponse> ListHealthEventsAsync(ListHealthEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMonitors



        /// <summary>
        /// Lists all of your monitors for Amazon CloudWatch Internet Monitor and their statuses,
        /// along with the Amazon Resource Name (ARN) and name of each monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMonitors service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        Task<ListMonitorsResponse> ListMonitorsAsync(ListMonitorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags for a resource. Tags are supported only for monitors in Amazon CloudWatch
        /// Internet Monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.BadRequestException">
        /// A bad request was received.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerErrorException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.NotFoundException">
        /// The request specifies something that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.TooManyRequestsException">
        /// There were too many requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds a tag to a resource. Tags are supported only for monitors in Amazon CloudWatch
        /// Internet Monitor. You can add a maximum of 50 tags in Internet Monitor.
        /// 
        ///  
        /// <para>
        /// A minimum of one tag is required for this call. It returns an error if you use the
        /// <code>TagResource</code> request with 0 tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.BadRequestException">
        /// A bad request was received.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerErrorException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.NotFoundException">
        /// The request specifies something that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.TooManyRequestsException">
        /// There were too many requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.BadRequestException">
        /// A bad request was received.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerErrorException">
        /// There was an internal server error.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.NotFoundException">
        /// The request specifies something that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.TooManyRequestsException">
        /// There were too many requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMonitor



        /// <summary>
        /// Updates a monitor. You can update a monitor to add or remove resources, or to change
        /// the status of the monitor. You can't change the name of a monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMonitor service method, as returned by InternetMonitor.</returns>
        /// <exception cref="Amazon.InternetMonitor.Model.AccessDeniedException">
        /// You don't have sufficient permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.InternalServerException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.LimitExceededException">
        /// The request exceeded a service quota.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ResourceNotFoundException">
        /// The request specifies a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.InternetMonitor.Model.ValidationException">
        /// Invalid request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/internetmonitor-2021-06-03/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        Task<UpdateMonitorResponse> UpdateMonitorAsync(UpdateMonitorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}